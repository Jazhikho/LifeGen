using UnityEngine;
using TMPro;

public class InputManager : MonoBehaviour
{
    public TMP_InputField planetAgeInput;
    public TMP_InputField blackbodyTempInput;
    public TMP_InputField hydroCoverInput;
    public TMP_InputField starLuminosityInput;
    public TreeOfLifeGenerator treeGenerator;


    public void OnGenerateButtonClicked()
    {
        float planetAge = float.Parse(planetAgeInput.text);
        float blackbodyTemp = float.Parse(blackbodyTempInput.text);
        float hydroCover = float.Parse(hydroCoverInput.text);
        float starLuminosity = float.Parse(starLuminosityInput.text);

        treeGenerator.PlanetAge = planetAge;
        treeGenerator.BlackbodyTemp = blackbodyTemp;
        treeGenerator.HydroCover = hydroCover;
        treeGenerator.StarLuminosity = starLuminosity;

        treeGenerator.GenerateTreeOfLife();
    }
}