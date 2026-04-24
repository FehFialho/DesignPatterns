using Lady.Interfaces;

namespace Lady.Scene;

public partial class Board
{
    private readonly Factory factory;
    private IDrawStrategy? strategy = null;

    public Board(Factory factory)
    {
        InitializeComponent();

        this.factory = factory;

        this.KeyPreview = true;
        ConfigPanels();
    }
}