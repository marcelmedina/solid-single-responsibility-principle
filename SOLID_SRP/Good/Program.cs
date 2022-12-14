using SOLID_SRP;
using SOLID_SRP.Models;

var order = new Order(1);
var validator = new OrderValidator(order);
var saver = new OrderSaver(order);
var notifier = new OrderNotifier(order);
var processor = new OrderProcessor(validator, saver, notifier);
processor.Process();
