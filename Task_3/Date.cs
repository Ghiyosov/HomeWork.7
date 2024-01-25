namespace Task_3;

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public Date(int day, int month, int year)
    {
       if (day <=31) _day = day;
        else _day = 00;
        if (month <=12) _month = month;
        else _month = 00;
        _year = year;
    }
    public Date(int day, int month)
    {
       if (day <=31) _day = day;
        else _day = 00;
        if (month <=12) _month = month;
        else _month = 00;
    }
      public Date(int day)
    {
        _day = day;
    }
    public Date(){}


    public void SetDate(int day, int month, int year)
    {
        if (day <=31) _day = day;
        else _day = 00;
        if (month <=12) _month = month;
        else _month = 00;
        _year = year;
    }

    public int GetDay()
    {
        return _day;
    }
    public int GetMonth()
    {
        return _month;
    }
    public int GetYear()
    {
        return _year;
    }
    public string ToString()
    {
        return $"{_day}/{_month}/{_year}";
    }
}
