using ConsoleAppSample;
using System;
using System.Threading.Tasks;

SampleCode sample = new SampleCode();




///// لطفا نمونه بنویسید که خروجی بالا به صورت Async

await sample.PrintAsync("Hello");
await sample.PrintAsync("world");
await sample.PrintAsync("Ali");


//// لطفا نمونه بنویسید که خروجی بالا به صورت موازی اجرا شود

await Task.WhenAll(sample.PrintAsync("Hello"), sample.PrintAsync("world"), sample.PrintAsync("Ali"));