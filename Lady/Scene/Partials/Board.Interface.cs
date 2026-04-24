using System.Reflection;
using Lady.Interfaces;

namespace Lady.Scene;

partial class Board
{
    
    private List<Button> factoriesButtons = [];
    private List<Button> strategiesButtons = [];

        public void ConfigPanels()
    {
        var assembly = Assembly.GetExecutingAssembly();

        ConfigPanel<IDrawStrategy>(assembly, strategiesButtons, t => strategy = t);
        ConfigPanelFactory();

        ButtonPositions();
        this.Resize += (s, e) => ButtonPositions();
    }
    public void ConfigPanel<T>(Assembly a, List<Button> buttons, Action<T?> setHandle)
    {   
        var children = a.GetTypes()
            .Where(t => 
                typeof(T).IsAssignableFrom(t) 
                && !t.IsAbstract                       
                && t.IsClass
            )
            .ToList();

        for(int i=0; i<children.Count; i++)
        {
            var chi = children[i];
            Button bt = new Button();
            bt.Text = chi.Name;
            bt.Size = new Size(100,100);
            bt.BackColor = Color.White;
        

            bt.Click += (s,e) =>
            {   
                bool isClicked = false;
                if(bt.BackColor == Color.Azure)
                    isClicked = true;
                foreach (Control c in buttons) c.BackColor = Color.White;
                if(isClicked)
                {
                    setHandle(default);
                    return;
                }
                bt.BackColor = Color.Azure;
                setHandle((T)Activator.CreateInstance(chi)!);
            };
            buttons.Add(bt);
            this.Controls.Add(bt);
        }
    }


    private void ButtonPositions()
    {
        ButtonPositionsShapes();
        ButtonPositionsStrategies();
    }
    private void ButtonPositionsShapes()
    {
        int size = 100;
        int startY = 40;
        int startX = (int)(ClientSize.Width / 2 - (double)factoriesButtons.Count/2*size);

        for(int i=0; i< factoriesButtons.Count; i++)
        {
            var bt = factoriesButtons[i];
            int y = startY;
            int x = startX + i*size;
            bt.Location = new Point(x,y);
        }
    }
    private void ButtonPositionsStrategies()
    {
        int size = 100;
        int startY = (int)(ClientSize.Height / 2 - (double)strategiesButtons.Count/2*size);
        int startX = 40;

        for(int i=0; i< strategiesButtons.Count; i++)
        {
            var bt = strategiesButtons[i];
            int y = startY + i*size;
            int x = startX;
            bt.Location = new Point(x,y);
        }
    }


}
