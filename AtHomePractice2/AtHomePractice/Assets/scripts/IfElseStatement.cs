using UnityEngine;

public class IfElseStatement : MonoBehaviour
{
    public int levelOne = 0, levelTwo = 1, levelThree = 2, currentLevel;

    private void Start()
    {
        currentLevel = levelOne;
    }


    public void Update()
    {
        if (currentLevel == levelOne)
        {
            print("Level One");
        }
        else if (currentLevel == levelTwo)
        {
            print("Level Two");
        }
        else if (currentLevel == levelThree)
        {
            print("Level Three");
        }
        else
        {
            print("Invalid");
        }
    }
}