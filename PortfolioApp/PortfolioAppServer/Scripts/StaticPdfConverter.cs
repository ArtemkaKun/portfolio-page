using DinkToPdf;

namespace PortfolioAppServer.Scripts;

public static class StaticPdfConverter
{
    public static SynchronizedConverter Converter { get; } = new(new PdfTools());
}