class Report
{
    private string _title;
    private string _author;
    private string _pagesize;
    private string _orientation;
    private string _watermark;
    private string _header;
    private string _footer;
    private bool _includeCharts;
    private bool _includeTableOfContents;
    private bool _includePageNumbers;
    private int _fontSize;
    private string _fontFamily;

    public Report(string title, string Author, string PageSize, string Orientation, string Watermark, string Header, string Footer, bool IncludeCharts, bool IncludeTableOfContents, bool IncludePageNumbers, int FontSize, string FontFamily)
    {
        _title = title;
        _author = Author;
        _pagesize = PageSize;
        _orientation = Orientation;
        _watermark = Watermark;
        _header = Header;
        _footer = Footer;
        _includeCharts = IncludeCharts;
        _includeTableOfContents = IncludeTableOfContents;
        _includePageNumbers = IncludePageNumbers;
        _fontSize = FontSize;
        _fontFamily = FontFamily;
    }

}