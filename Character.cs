namespace ApplicationTest
{
    public class Character
    {
        private string name;
        private bool isAlive;
        private int hp;
        private string specialSkill;

        public Character(string name, int hp, string specialSkill)
        {
            this.name = name;
            this.isAlive = true;
            this.hp = hp;
            this.specialSkill = specialSkill;

        }
        

        public int Injure(int damage) {
            hp = hp - damage;
            return hp;
        }
            
        public void Die()
        {
            if (hp <= 0)
            {
                isAlive = false;
            }
        }
    }

    
    
}
