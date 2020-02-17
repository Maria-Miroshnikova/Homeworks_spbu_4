module Program

let listRevolution (list:list<_>) =
    let mutable newList = []
    for i in 0 .. list.Length - 1 do
        newList <- list.Item(i) :: newList
    newList

let test =
    let testList1 = [1; 2; 3; 4; 5]
    let testAnswer1 = [5; 4; 3; 2; 1]
    let testList2 = []
    let testList3 = [1]
    assert (testAnswer1.Equals(listRevolution(testList1)))
    assert (testList2.Equals(listRevolution(testList2)))
    assert (testList3.Equals(listRevolution(testList3)))