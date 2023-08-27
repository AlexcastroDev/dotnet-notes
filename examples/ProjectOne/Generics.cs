namespace GenericsExample {

    public interface ISubscription {
        void Save();
    }

    // In this example i can declare each type  as a Class or Interface
    // public class DataContext<T, U, V> 
    //     where T : Person
    //     where U : Payment
    //     where V : ISubscription
    // {
    //     public void Save(T entity) {
    //     }

    //     public void Save(U entity) {
    //     }

    //     public void Save(V entity) {
    //     }
    // }

    // In this example we are going to create a generic class that can 
    // be used to save different types of entities
    // public class DataContext<T, U, V> {
    //     public void Save(T entity) {
    //     }

    //     public void Save(U entity) {
    //     }

    //     public void Save(V entity) {
    //     }
    // }

    public class DataContext<T> {
        public void Save(T entity) {
            
        }   
    }

    public class Person {}
    public class Payment {}
    public class Subscription {}

    public class Main {
        public void Run() {
            var context = new DataContext<Person>();
            var person = new Person();
            var payment = new Payment();
            var subscription = new Subscription();
            
            context.Save(person);
            // context.Save(payment); // This is not allowed

        }
    }
}

