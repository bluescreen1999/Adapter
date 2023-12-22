// Using the Adapter to make Adaptee work with ITarget
Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

target.Request();
