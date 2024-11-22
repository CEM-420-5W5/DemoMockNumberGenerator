namespace DemoMockNumberGenerator.Models
{
    public class Pack
    {
        private static Random Random = new Random();

        public enum Rarity
        {
            Common,
            Rare
        }

        public int NbCards { get; set; }
        public float RareProbability { get; set; }

        public List<Rarity> OpenPack()
        {
            List<Rarity> rarities = new List<Rarity>();
            for (int i = 0; i < NbCards; i++)
            {
                if (Random.NextSingle() < RareProbability)
                {
                    rarities.Add(Rarity.Rare);
                }
                else
                {
                    rarities.Add(Rarity.Common);
                }
            }
            return rarities;
        }
    }
}
