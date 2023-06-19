using System.Collections;

public class Bank : IEnumerable
{
    private List<Account> _accounts = new List<Account>();

    public void Add(Account acc) => _accounts.Add(acc);

    public IEnumerator<Account> GetEnumerator()
    {
        return this._accounts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public void SortByAccountNumber()
    {
        _accounts.OrderBy(a => a.AccountNumber);
    }

    public bool ContainsAccount(Account acc)
    {
        return _accounts.Contains(acc);
    }
}