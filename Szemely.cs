namespace WFA24072501
{
    internal class Szemely
    {
        public string Nev { get; set; }
        public DateTime SzulDatum { get; set; }
        public bool Jogositvany { get; set; }
        public int Fizetes { get; set; }
        public Jogviszony Jogviszony { get; set; }

        public Szemely(string row)
        {
            string[] splts = row.Split(';');
            Nev = splts[0];
            SzulDatum = DateTime.Parse(splts[1]);
            Jogositvany = splts[2] == "V";
            Fizetes = int.Parse(splts[3]);
            Jogviszony = splts[4] switch
            {
                "A" => Jogviszony.Alkalmazott,
                "V" => Jogviszony.Vezeto,
                "T" => Jogviszony.Tulajdonos,
                _ => throw new Exception(),
            };
        }
    }

    internal enum Jogviszony
    {
        Alkalmazott,
        Vezeto,
        Tulajdonos,
    }
}
