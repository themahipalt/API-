// function fun()
// {
//     function fun2() //inner function
//     {
//         i=100;
//     }
//     fun2();
//     console.log(i);
// }
// fun();

function fun()
{
    function fun2()
    {
        var i=100;
    }
    fun2();
    console.log(i);
}
fun();