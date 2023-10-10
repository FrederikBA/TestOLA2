using Core.Bowling;

var f1 = new Frame(new List<Roll> { new Roll(10)});
var f2 = new Frame(new List<Roll> { new Roll(4), new Roll(5) });
var f3 = new Frame(new List<Roll> { new Roll(9), new Roll(0) });
var f4 = new Frame(new List<Roll> { new Roll(10)});
var f5 = new Frame(new List<Roll> { new Roll(0), new Roll(0) });
var f6 = new Frame(new List<Roll> { new Roll(0), new Roll(10) });
var f7 = new Frame(new List<Roll> { new Roll(3), new Roll(6) });
var f8 = new Frame(new List<Roll> { new Roll(10) });
var f9 = new Frame(new List<Roll> { new Roll(5), new Roll(5) });
var f10 = new Frame(new List<Roll> { new Roll(0), new Roll(0), new Roll(10) });

var game = new Game(new List<Frame> {f1, f2, f3, f4, f5, f6, f7, f8, f9, f10});


Console.WriteLine("Hello, World!");
