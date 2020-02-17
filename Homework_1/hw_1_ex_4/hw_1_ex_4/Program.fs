module Program

let makingPowerList (n, m) =
    let (list:list<float>) = [for i in n .. n + m -> 2.0 ** i]
    list

let test = 
    let testData = [(1.0, 0.0); (0.0, 5.0); (-2.0, 4.0); (4.0, -2.0)]
    let testAnswer = [[2.0]; [1.0; 2.0; 4.0; 8.0; 16.0; 32.0]; [0.25; 0.5; 1.0; 2.0; 4.0]; []]
    for i in 0 .. testData.Length - 1 do
        assert (testAnswer.Item(i).Equals(makingPowerList(testData.Item(i))))