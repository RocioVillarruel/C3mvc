namespace C3mvc.Models;
class Team
{
    public string name { get; set; }
    public int id { get; set; }

public Team(string name, int id)
{
    this.name = name;
    this.id=id;
}

}