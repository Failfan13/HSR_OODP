static class EmailParser
{
    public static (string recipient, string domain, string topLevelDomain) ParseEmail(string email)
    {
        var configMail = email.Replace(" ", "");

        int indexAt = configMail.IndexOf('@');
        int indexDot = configMail.LastIndexOf('.');

        if (!configMail.Contains('.') || !configMail.Contains('@') || indexDot < indexAt)
            return (null, null, null)!;

        var recipient = configMail.Substring(0, indexAt);
        var domain = configMail.Substring(indexAt + 1);
        var topLevel = configMail.Substring(indexDot + 1);

        return (recipient, domain, topLevel);
    }
}