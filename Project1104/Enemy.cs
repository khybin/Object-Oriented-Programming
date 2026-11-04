class Enemy
{
    public string Name;
    public int Hp = 0;
    public bool IsElite;
    public bool IsBoss;

    public Enemy(string Name, bool IsElite, bool IsBoss)
    {
        if (Name == null || Name.Length <= 0)
        {
            this.Name = "INVALID ENEMY NAME";
        } else
        {
            this.Name = Name;
        }

        this.IsElite = IsElite;
        this.IsBoss = IsBoss;
    }
}

