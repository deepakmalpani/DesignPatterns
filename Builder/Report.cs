class Report
{
    private string _Title;
    private string _Author;
    private string _PageSize;
    private string _Orientation;
    private string _Watermark;
    private string _Header;
    private string _Footer;
    private bool _IncludeCharts;
    private bool _IncludeTableOfContents;
    private bool _IncludePageNumbers;
    private int _FontSize;
    private string _FontFamily;

    public Report(string Title, string Author, string PageSize = "", string Orientation = "", string Watermark = "", string Header = "", string Footer = "", bool IncludeCharts = false, bool IncludeTableOfContents = false, bool IncludePageNumbers = false, int FontSize = 12, string FontFamily = "Arial")
    {
        _Title = Title;
        _Author = Author;
        _PageSize = PageSize;
        _Orientation = Orientation;
        _Watermark = Watermark;
        _Header = Header;
        _Footer = Footer;
        _IncludeCharts = IncludeCharts;
        _IncludeTableOfContents = IncludeTableOfContents;
        _IncludePageNumbers = IncludePageNumbers;
        _FontSize = FontSize;
        _FontFamily = FontFamily;
    }

}