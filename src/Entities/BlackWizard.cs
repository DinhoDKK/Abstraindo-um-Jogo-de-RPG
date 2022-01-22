namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(String Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

         public override string Attack(){
            return this.Name + " Lançou Magia Negra";
        }
        public string Attack(int Bonus){

            if(Bonus > 6){
            return this.Name + " Lançou Magia Negra super efetiva com bonus de ataque de " + Bonus;
            }else {
                return this.Name + " Lançou Magia Negra com força franca com bonus de " + Bonus;
            }
        }
    }
}