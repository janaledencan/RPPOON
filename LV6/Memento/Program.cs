using Memento.MyMemento;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.

            ToDoItem toDoItem = new ToDoItem("Nobody", "Never and forewer", DateTime.Now);
            toDoItem.Rename("We will");


            CareTaker careTaker = new CareTaker(); 
            careTaker.Memento = careTaker.StoreState();
            Console.WriteLine(toDoItem.ToString());

            //4.

            BankAccount bankAccount = new BankAccount("Jana", "Croatia", 3500);
            bankAccount.ChangeOwnerAddress("UK");

            BankAccountSystem bankAccountSystem = new BankAccountSystem();
            bankAccountSystem.BankMemento = bankAccountSystem.previousStates();
            Console.WriteLine(bankAccount);
        }
    }
}
