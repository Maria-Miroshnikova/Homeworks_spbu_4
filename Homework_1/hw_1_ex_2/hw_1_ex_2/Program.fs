module Program

let iterationFibonacci n =
    let mutable fibonacciOne = 0
    let mutable fibonacciTwo = 1
    if n = 0
       then 0
    else
        for i in 1 .. n - 1 do
           let tmp = fibonacciOne
           fibonacciOne <- fibonacciTwo
           fibonacciTwo <- fibonacciTwo + tmp
        fibonacciTwo

let test =
    let testIndexes = [0; 1; 2; 3; 8]
    let testAnswers = [0; 1; 1; 2; 21]    
    for i in 0 .. testIndexes.Length - 1 do
        assert (testAnswers.Item(i) = iterationFibonacci(testIndexes.Item(i)))