﻿namespace ErgoLux;

public partial class Form2 : Form
{
    
    public Form2()
    {
        InitializeComponent();

        //double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        //double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        //formsPlot1.Plot.AddScatter(dataX, dataY);
        //formsPlot1.Refresh();

        double[] sin = ScottPlot.DataGen.Sin(51);
        double[] cos = ScottPlot.DataGen.Cos(51);

        formsPlot1.Plot.AddSignal(sin);
        formsPlot1.Plot.AddSignal(cos);

        //ScottPlot.Plottable.Crosshair ch = new();
        //ch.VerticalLine.X = 42;
        //ch.HorizontalLine.Y = 0.48;
        //ch.VerticalLine.DragEnabled = true;
        //ch.HorizontalLine.DragEnabled = true;
        //ch.VerticalLine.Dragged += new System.EventHandler(OnDraggedVertical);

        //formsPlot1.Plot.Add(ch);

        ScottPlot.Plottable.VLine vLine = new();
        vLine.DragEnabled = true;
        vLine.X = 10;

        vLine.LineStyle = ScottPlot.LineStyle.Dash;
        vLine.LineWidth = 1;
        vLine.Color = System.Drawing.Color.FromArgb(200, System.Drawing.Color.Red);
        vLine.PositionLabel = true;
        vLine.PositionLabelBackground = vLine.Color;
        vLine.Dragged += new System.EventHandler(OnDraggedVertical);

        formsPlot1.Plot.Add(vLine);

        ScottPlot.Plottable.VLineVector vlines = new();
        vlines.Xs = new double[] { 25 };
        vlines.Color = System.Drawing.Color.Red;
        vlines.PositionLabel = true;
        vlines.PositionLabelBackground = vlines.Color;
        vlines.DragEnabled = true;

        formsPlot1.Plot.Add(vlines);

        formsPlot1.Plot.Title("Crosshair Demo");
        formsPlot1.Plot.BottomAxis.Label("Horizontal Axis");
        formsPlot1.Plot.LeftAxis.Label("Vertical Axis");
        formsPlot1.Refresh();
    }

    private void OnDraggedVertical(object? sender, EventArgs e)
    {
        //formsPlot1.Refresh();
    }


}

