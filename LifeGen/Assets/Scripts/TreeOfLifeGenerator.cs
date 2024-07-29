using UnityEngine;
using System.Collections.Generic;

class LifeForm
{
    public string Name;
    public float AppearanceTime;
    public List<LifeForm> Descendants;
}

public class TreeOfLifeGenerator : MonoBehaviour
{
    // Input parameters
    public float PlanetAge;
    public float BlackbodyTemp;
    public float HydroCover;
    public float StarLuminosity;

    // Tree of life root
    private LifeForm rootLifeForm;

    void Start()
    {
        GenerateTreeOfLife();
    }

    public void GenerateTreeOfLife()
    {
        // Initialize the root of the tree
        rootLifeForm = new LifeForm { Name = "Last Universal Common Ancestor", AppearanceTime = 0 };

        // Generate the tree based on planet characteristics
        GenerateBranches(rootLifeForm, PlanetAge);

        // Visualize the tree (implement this method later)
        VisualizeTree(rootLifeForm);
    }

    void GenerateBranches(LifeForm parent, float remainingTime)
    {
        // Base case: if remaining time is too short, stop branching
        if (remainingTime < 0.1f) return;

        // Randomly decide to create a new branch
        if (Random.value > 0.5f)
        {
            LifeForm newLife = new LifeForm
            {
                Name = GenerateSpeciesName(),
                AppearanceTime = PlanetAge - remainingTime
            };
            parent.Descendants.Add(newLife);

            // Recursively generate sub-branches
            GenerateBranches(newLife, remainingTime * Random.Range(0.5f, 0.9f));
        }

        // Continue with the current branch
        GenerateBranches(parent, remainingTime * Random.Range(0.6f, 0.95f));
    }

    string GenerateSpeciesName()
    {
        // Implement a method to generate random species names
        return "Species_" + Random.Range(1000, 9999);
    }

    void VisualizeTree(LifeForm root)
    {
        // Implement a method to visualize the tree
        // This could involve instantiating GameObjects and arranging them in 3D space
        Debug.Log("Visualizing tree starting with: " + root.Name);
    }
}