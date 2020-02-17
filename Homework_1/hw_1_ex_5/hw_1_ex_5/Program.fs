module Program

let findFirstAppearance ((list:list<int>), (number:int)) =
    let mutable index = -1
    let mutable i = 0
    while ((i < list.Length) && (index = -1)) do
        if list.Item(i) = number
           then index <- i
        else
           i <- i + 1
    index

let test =
    let testData = [([1; 1; 1], 2); ([], 2); ([2; 1; 1], 2); ([1; 2; 1], 2); ([1; 1; 2], 2); ([1; 1; 2; 1; 2; 1], 2)]
    let testAnswer = [-1; -1; 0; 1; 2; 2]
    for i in 0 .. testData.Length - 1 do
        assert (testAnswer.Item(i).Equals(findFirstAppearance(testData.Item(i))))
        



        