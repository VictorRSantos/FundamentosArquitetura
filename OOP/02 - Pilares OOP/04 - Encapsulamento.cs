namespace OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraExpressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
}
