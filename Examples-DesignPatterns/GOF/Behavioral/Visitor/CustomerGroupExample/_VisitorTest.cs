﻿using NUnit.Framework;

namespace GOF.Behavioral.Visitor.CustomerGroupExample
{
  [TestFixture]
  public class _VisitorTest
  {
    [Test]
    public void Test()
    {
      Customer c = new Customer("customer1");
      c.AddOrder(new Order(".order1", "..item1"));
      c.AddOrder(new Order(".order2", "..item1"));
      c.AddOrder(new Order(".order3", "..item1"));

      Customer c2 = new Customer("customer2");
      Order o = new Order(".order_a");
      o.AddItem(new Item("..item_a1"));
      o.AddItem(new Item("..item_a2"));
      o.AddItem(new Item("..item_a3"));
      c2.AddOrder(o);
      c2.AddOrder(new Order(".order_b", "..item_b1"));


      CustomerGroup customers = new CustomerGroup();
      customers.AddCustomer(c);
      customers.AddCustomer(c2);

      Report visitor = new Report();

      customers.Accept(visitor);

      visitor.DisplayResults();
    }
  }
}