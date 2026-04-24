using System.Drawing.Drawing2D;
using Lady.Interfaces;

namespace Lady.Scene;

public partial class Board : Form
{
    #region CONFIGURATION

    private string? currentFactory;
    
    #endregion
    #region INTERFACE 
    
    public void ConfigPanelFactory()
    {
        // Voce deve preencher o campo indicado onde falta algo no código, para isso você deve analisar
        // o código, para encerrar só é necessário prestar atenção nas linhas entre a marcação "// *"


        // *
        foreach(var fact in factory.dict)
        // *
        {
            var child = fact.Value.Method.ReturnType;
            Button bt = new Button();
            bt.Text = fact.Key;
            bt.Size = new Size(100,100);
            bt.BackColor = Color.White;
        
            // Função que vai rodar toda vez que o botão for apertado, os parâmetros (s,e) não são relevantes 
            // para a conclusão da atividade
            bt.Click += (s,e) =>
            {   
                bool isClicked = false;
                if(bt.BackColor == Color.Azure)
                    isClicked = true;
                foreach (Control c in factoriesButtons) c.BackColor = Color.White;
                if(isClicked)
                {
                    currentFactory = null;
                    return;
                }
                bt.BackColor = Color.Azure;

                // Além de trocar a cor do botão, como acontece a cima, o que é necessário fazer?
                //=======================================
                // AQUI FALTA ALGO...
                //
                //=======================================
            };
            factoriesButtons.Add(bt);
            this.Controls.Add(bt);
        }
    }

    #endregion
    #region FUNCTIONS

    private List<Drawable> Draw = [];
    
    protected override void OnMouseClick(MouseEventArgs e)
    {

        base.OnMouseClick(e);
        Past = [];

        if(currentFactory is null || strategy is null)
            return;
        var x = e.X;
        var y = e.Y;

        
        // Para completar essa atividade você precisa saber que a lista "Draw" é a lista que guarda
        // os objetos que estão sendo desenhados na tela atualmente
        //================================================================
        // AQUI FALTA ALGO...
        //
        //
        //
        //
        //
        //
        //================================================================

        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Graphics g = e.Graphics;

        //==============================================================
        // AQUI FALTA ALGO...
        //
        //
        //
        //
        //
        //==============================================================
    }

    #endregion    
}

public record Drawable
{
    public required IShape Shape;
    public required IDrawStrategy Strategy;
}