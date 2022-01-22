namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(String Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public override string Attack(){
            return this.Name + " Atacou com sua Adaga";
        }
        public string Attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " Atacou com sua Adaga, e obteve um super ataque de crítico " + Bonus;
            }else {
                return this.Name + " Atacou com sua Adaga, e obteve um ataque de crítico " + Bonus;
            }
        }
    }
    
}