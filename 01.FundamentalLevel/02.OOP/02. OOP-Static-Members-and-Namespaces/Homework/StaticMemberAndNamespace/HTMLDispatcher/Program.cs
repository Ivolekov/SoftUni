using System;
using HTMLDispatcher;

class Program
{
    static void Main()
    {
        try
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id", "page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");
        }
        catch (ArgumentNullException)
        {
            return;
        }
    }
}