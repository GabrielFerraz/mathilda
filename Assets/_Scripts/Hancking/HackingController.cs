using UnityEngine;
public class HackingController : MonoBehaviour
{
    public GameObject buttonPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartPuzzle("Q|3,S|1,Q|1,Q|1,Q|1,Q|3,Q|3,Q|3,Q|2,E|2,Q|3,Q|3,N|0,Q|0,Q|1,H|3,Q|1,Q|1,Q|1,Q|1,Q|3,Q|1,A|1,Q|1,Q|1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartPuzzle(string puzzle)
    {
        var cells = puzzle.Split(',');

        var position = new Vector3(250, 500, 0);
        var x = 250f;
        var y = 500f;
        var cellNumber = 0;
        foreach (var c in cells)
        {
            var obj = Instantiate(buttonPrefab, new Vector3(x, y, 0), Quaternion.identity, gameObject.transform);
            var button = obj.GetComponent<LetterButton>();
            button.SetValues(c);
            Debug.Log("cell number " + cellNumber.ToString());
            y -= cellNumber != 4 ? 0f : 50f;
            x += cellNumber != 4 ? 50f : -200f;
            cellNumber += cellNumber != 4 ? 1 : -4;
        }
    }
}
