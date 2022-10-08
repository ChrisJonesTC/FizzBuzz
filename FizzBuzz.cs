//FizzBuzz WhiteBoard Challenge

//Write a public method that accepts a number
//1.Access Modifier = public
//2.Return Type = string 
//3.Method Name = FizzBuzz
//4.Parameters = (int number)
/*5.Scope = {
                if(number)
                {

                }
                return answer
            }
*/
public string FizzBuzz(int number)
{
    //Inferred variable assigned to combine fizz & buzz as answer += 
    var answer = "";
    
    //when the number is divisible by 3 return the word fizz
    if (number % 3 == 0)
    {
        answer = "fizz";
    }
    
    //when the number is divisible by 5 return the word buzz
    if (number % 5 == 0)
    {
        answer += "buzz"; //when the number is divisible by both, return the word fizzbuzz
    } //answer = answer + "buzz"

    return answer;
}