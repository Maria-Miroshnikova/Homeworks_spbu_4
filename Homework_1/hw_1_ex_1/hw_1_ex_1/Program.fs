module Program

let rec factorial x =
    if x <= 1
    then 1
    else
        let resultOfRec = factorial(x - 1)
        let result = x * resultOfRec
        result

let test =
    let testData = [0; 1; 2; 3; 5]
    let testAnswers = [1; 1; 2; 6; 120]
    for i in 0 .. testData.Length - 1 do
        assert (testAnswers.Item(i) = factorial(testData.Item(i)))