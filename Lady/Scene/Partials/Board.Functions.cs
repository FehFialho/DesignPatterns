using Lady.Interfaces;

namespace Lady.Scene;

public partial class Board
{
    private List<Drawable> Past = [];

    private void Undo()
    {
        if(Draw.Count <= 0)
            return;

        Past.Add(Draw[Draw.Count-1]);
        Draw.RemoveAt(Draw.Count-1);
        this.Invalidate();
    }
    private void Redo()
    {
        if(Past.Count <= 0)
            return;
        Draw.Add(Past[Past.Count-1]);
        Past.RemoveAt(Past.Count-1);

        this.Invalidate();
    }

    
    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        if(e.Control && e.KeyCode == Keys.Z)
            Undo();
        if(e.Control && e.KeyCode == Keys.Y)
            Redo();
        if(e.KeyCode == Keys.Escape)
            this.Close();
    }

}

