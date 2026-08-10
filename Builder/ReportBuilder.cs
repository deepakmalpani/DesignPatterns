class ReportBuilder
{
    private string _Title;
    private string _Author;
    private string _PageSize = "";
    private string _Orientation = "";
    private string _Watermark = "";
    private string _Header = "";
    private string _Footer = "";
    private bool _IncludeCharts = false;
    private bool _IncludeTableOfContents = false;
    private bool _IncludePageNumbers = false;
    private int _FontSize = 12;
    private string _FontFamily = "Arial";

    public ReportBuilder SetTitle(string title)
    {
        _Title = title;
        return this;
    }
    public ReportBuilder SetAuthor(string author)
    {
        _Author = author;
        return this;
    }
    public ReportBuilder SetPageSize(string pageSize)
    {
        _PageSize = pageSize;
        return this;
    }
    public ReportBuilder SetOrientation(string orientation)
    {
        _Orientation = orientation;
        return this;
    }
    public ReportBuilder SetWatermark(string watermark)
    {
        _Watermark = watermark;
        return this;
    }
    public ReportBuilder SetHeader(string header)
    {
        _Header = header;
        return this;
    }
    public ReportBuilder SetFooter(string footer)
    {
        _Footer = footer;
        return this;
    }
    public ReportBuilder SetIncludeCharts(bool includeCharts)
    {
        _IncludeCharts = includeCharts;
        return this;
    }
    public ReportBuilder SetIncludeTableOfContents(bool includeTableOfContents)
    {
        _IncludeTableOfContents = includeTableOfContents;
        return this;
    }
    public ReportBuilder SetIncludePageNumbers(bool includePageNumbers)
    {
        _IncludePageNumbers = includePageNumbers;
        return this;
    }
    public ReportBuilder SetFontSize(int fontSize)
    {
        _FontSize = fontSize;
        return this;
    }
    public ReportBuilder SetFontFamily(string fontFamily)
    {
        _FontFamily = fontFamily;
        return this;
    }
    public Report Build()
    {
        return new Report(_Title, _Author, _PageSize, _Orientation, _Watermark, _Header, _Footer, _IncludeCharts, _IncludeTableOfContents, _IncludePageNumbers, _FontSize, _FontFamily);
    }
}