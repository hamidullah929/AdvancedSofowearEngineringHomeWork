namespace _05_FactoryDesignPattern{


    public class OrderPizza{
     
 
        public void  OrderMyPizza(Pizza _pizza)
        {
            if(_pizza is Chesses)
            {
                _pizza = new Chesses();
            }
            if(_pizza is AnarPizza)
            {
                _pizza = new AnarPizza();
            }

            _pizza.Prepare();
            _pizza.bake();
            _pizza.Box();
            _pizza.Cut();

          
        }
    }
}