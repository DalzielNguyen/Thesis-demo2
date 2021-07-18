using System;

[Serializable]
public class Data
{
    public string name;
    public string period;
    public string date;
    public string culture;
    public string description;
    public string sound;

    public string createSoundText()
    {
        return string.Format("{0} ra đời vào {1}, được xác định là vào {2}  thuộc về văn hoá của {3}. {4}.", name, period, date, culture, description);
    }
}
