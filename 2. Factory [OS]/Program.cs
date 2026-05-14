Factory factory = new();

factory.AddFactory("windows", () => new WindowsButton());
factory.AddFactory("mac", () => new MacButton());
factory.AddFactory("linux", () => new LinuxButton());

Application app = new Application(factory, "mac");
app.Logic();
