namespace W3._2C1_Roll_The_Dice.Tests;

[TestClass]
public class RollTheDiceTest
{
    /*
        Test the creation of a die. Check if the value of a die does not exceed the specified sides. For example a six sided dice should have a rolled a value BETWEEN 1 and 6 (inclusive). Also check if both fields have been set correctly.

        Use the following Assert methods:
        - Assert.AreEqual
        - Assert.IsNotNull
        - Assert.IsTrue
    */
    [TestMethod]
    public void Create_Die()
    {
        var expected = new Die(6,"Red");

        var result = new Die(6,"Red");
        var resultValue = expected.Value > 1 && expected.Value <= 6;

        Assert.IsNotNull(expected);
        Assert.IsTrue(resultValue);
        Assert.AreEqual(expected.Sides, result.Sides);
    }
        /*
        Test the Roll method of multiple dice (4,6,8,10 and 20 sided). Like in the Create_Die test, 
        check if the value of a die does not exceed the specified sides. 
        For each die, call the Roll method 10 times (in a for loop) and assert the result after each method call.

        Use the following Assert methods:
        - Assert.IsTrue
    */
    [DataTestMethod]
    [DataRow(4)]
    [DataRow(6)]
    [DataRow(8)]
    [DataRow(10)]
    [DataRow(20)]
    public void Roll_Die(int sides)
    {
        var newDie = new Die(sides, "red");
        for (var i = 0; i < 10; i++) {
            newDie.Roll();
            Assert.IsTrue(newDie.Value <= sides);
        }
    }

    /*
        Test the creation of an empty DiceBag object. Check that the Dice field is not NULL and contains zero dice objects.
        
        Use the following Assert methods:
        - Assert.IsNotNull
        - Assert.AreEqual
    */
    [TestMethod]
    public void Create_DiceBag()
    {
        var diceBag = new DiceBag();
        Assert.IsNotNull(diceBag);
        Assert.AreEqual(diceBag.Dice.Count, 0);
    }

    /*
        Test the Add method by adding multiple sided dice to a dice bag. Check that the Dice field contains the correct number of dice, 
        that all dice contained in the Dice field are not NULL and that the values of all dice do not exceed the specified sides.
        
        Use the following Assert methods:
        - Assert.AreEqual
        - Assert.IsTrue
        - CollectionAssert.AllItemsAreNotNull
    */
    [TestMethod]
    public void Add_DiceToDiceBag()
    {
        List<int> lSides = new() { 4, 6, 8, 10, 20, 100 };

        // create new dice bag
        DiceBag diceBag = new ();

        foreach (int side in lSides)
        {
            // create a die for each side in the lSides list
            diceBag.Add(new Die(side, "red"));
        }

        Assert.AreEqual(diceBag.Dice.Count, lSides.Count);
        Assert.IsTrue(diceBag.Dice.Count == 6);
        CollectionAssert.AllItemsAreNotNull(diceBag.Dice);
    }

    /*
        Test the Reroll method of a dice bag after adding multiple sided dice to a dice bag. 
        Check if the current value of all die in the dice bag does not exceed the specified sides.
        
        Use the following Assert methods:
        - Assert.IsTrue
    */
    [TestMethod]
    public void Reroll_AllDiceInDiceBag()
    {
        List<int> lSides = new() { 4, 6, 8, 10, 20, 100 };

        // create new dice bag
        DiceBag DiceBag = new ();

        foreach (int side in lSides)
        {
            // create a die for each side in the lSides list
            DiceBag.Add(new Die(side, "red"));
        }

        // reroll all the dice in the bag
        DiceBag.Reroll();
        // asserts
        foreach (var die in DiceBag.Dice) 
            Assert.IsTrue(die.Value <= die.Sides);
    }
}