public class Job {
    public string _jobTitle;
    private string _companyName;
    private string _startDate;
    private string _endDate;

    public Job(string jobTitle, string companyName, string startDate, string endDate) {
        _jobTitle = jobTitle;
        _companyName = companyName;
        _startDate = startDate;
        _endDate = endDate;
    }

    public string GetJobTitle() {
        return _jobTitle;
    }

    public string GetCompanyName() {
        return _companyName;
    }

    public string GetStartDate() {
        return _startDate;
    }

    public string GetEndDate() {
        return _endDate;
    }

    public void DisplayJobDetail() {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate} - {_endDate}");
    }
}