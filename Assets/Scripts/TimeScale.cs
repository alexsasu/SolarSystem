using UnityEngine;
using System.Collections;

public class TimeScale : MonoBehaviour
{
    private float timeScale;
    
    private float sizeScaleSun = 50f;
    private float sizeScaleMercury = 0.66F;
    private float sizeScaleVenus = 1.9F;
    private float sizeScaleEarth = 2f;
    private float sizeScaleMoon = 0.2F;
    private float sizeScaleMars = 1f;
    private float sizeScaleJupiter = 22f;
    private float sizeScaleSaturn = 18f;
    private float sizeScaleUranus = 8f;
    private float sizeScaleNeptune = 8f;

    public static string header = "Solar System";
    public static string info = "Mercury\nVenus\nEarth\nMars\nJupiter\nSaturn\nUranus\nNeptune";

    public GUIStyle styleHeader;

    void OnGUI()
    {
        styleHeader.fontSize = 20;
        styleHeader.fontStyle = FontStyle.Bold;
        styleHeader.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 20, 30, 20), new GUIContent("Time Scale"));
        timeScale = GUI.HorizontalSlider(new Rect(10, 40, 150, 40), timeScale, -4, 4);

        Time.timeScale = Mathf.Exp(timeScale);

        GUI.Label(new Rect(10, 100, 100, 30), new GUIContent(header), styleHeader);
        GUI.Label(new Rect(10, 120, 400, 400), new GUIContent(info));


        GUI.Label(new Rect(Screen.width - 170, 20, 60, 20), new GUIContent("Sun"));
        sizeScaleSun = GUI.HorizontalSlider(new Rect(Screen.width - 170, 40, 150, 40), sizeScaleSun, 0, 150);
        GameObject.Find("Sun").transform.localScale = new Vector3(sizeScaleSun, sizeScaleSun, sizeScaleSun);

        GUI.Label(new Rect(Screen.width - 170, 60, 80, 20), new GUIContent("Mercury"));
        sizeScaleMercury = GUI.HorizontalSlider(new Rect(Screen.width - 170, 80, 150, 40), sizeScaleMercury, 0, 50);
        GameObject.Find("Mercury").transform.localScale = new Vector3(sizeScaleMercury, sizeScaleMercury, sizeScaleMercury);

        GUI.Label(new Rect(Screen.width - 170, 100, 80, 20), new GUIContent("Venus"));
        sizeScaleVenus = GUI.HorizontalSlider(new Rect(Screen.width - 170, 120, 150, 40), sizeScaleVenus, 0, 50);
        GameObject.Find("Venus").transform.localScale = new Vector3(sizeScaleVenus, sizeScaleVenus, sizeScaleVenus);

        GUI.Label(new Rect(Screen.width - 170, 140, 80, 20), new GUIContent("Earth"));
        sizeScaleEarth = GUI.HorizontalSlider(new Rect(Screen.width - 170, 160, 150, 40), sizeScaleEarth, 0, 80);
        GameObject.Find("Earth").transform.localScale = new Vector3(sizeScaleEarth, sizeScaleEarth, sizeScaleEarth);

        GUI.Label(new Rect(Screen.width - 170, 180, 60, 20), new GUIContent("Moon"));
        sizeScaleMoon = GUI.HorizontalSlider(new Rect(Screen.width - 170, 200, 150, 40), sizeScaleMoon, 0, 50);
        GameObject.Find("Moon").transform.localScale = new Vector3(sizeScaleMoon, sizeScaleMoon, sizeScaleMoon);

        GUI.Label(new Rect(Screen.width - 170, 220, 60, 20), new GUIContent("Mars"));
        sizeScaleMars = GUI.HorizontalSlider(new Rect(Screen.width - 170, 240, 150, 40), sizeScaleMars, 0, 50);
        GameObject.Find("Mars").transform.localScale = new Vector3(sizeScaleMars, sizeScaleMars, sizeScaleMars);

        GUI.Label(new Rect(Screen.width - 170, 260, 60, 20), new GUIContent("Jupiter"));
        sizeScaleJupiter = GUI.HorizontalSlider(new Rect(Screen.width - 170, 280, 150, 40), sizeScaleJupiter, 0, 100);
        GameObject.Find("Jupiter").transform.localScale = new Vector3(sizeScaleJupiter, sizeScaleJupiter, sizeScaleJupiter);

        GUI.Label(new Rect(Screen.width - 170, 300, 60, 20), new GUIContent("Saturn"));
        sizeScaleSaturn = GUI.HorizontalSlider(new Rect(Screen.width - 170, 320, 150, 40), sizeScaleSaturn, 0, 100);
        GameObject.Find("Saturn").transform.localScale = new Vector3(sizeScaleSaturn, sizeScaleSaturn, sizeScaleSaturn);

        GUI.Label(new Rect(Screen.width - 170, 340, 60, 20), new GUIContent("Uranus"));
        sizeScaleUranus = GUI.HorizontalSlider(new Rect(Screen.width - 170, 360, 150, 40), sizeScaleUranus, 0, 80);
        GameObject.Find("Uranus").transform.localScale = new Vector3(sizeScaleUranus, sizeScaleUranus, sizeScaleUranus);

        GUI.Label(new Rect(Screen.width - 170, 380, 60, 20), new GUIContent("Neptune"));
        sizeScaleNeptune = GUI.HorizontalSlider(new Rect(Screen.width - 170, 400, 150, 40), sizeScaleNeptune, 0, 80);
        GameObject.Find("Neptune").transform.localScale = new Vector3(sizeScaleNeptune, sizeScaleNeptune, sizeScaleNeptune);

        if (GUI.Button(new Rect(Screen.width - 170, 440, 50, 30), "Reset"))
        {
            sizeScaleSun = 50;
            sizeScaleMercury = 0.66F;
            sizeScaleVenus = 1.9F;
            sizeScaleEarth = 2;
            sizeScaleMoon = 0.2F;
            sizeScaleMars = 1;
            sizeScaleJupiter = 22;
            sizeScaleSaturn = 18;
            sizeScaleUranus = 8;
            sizeScaleNeptune = 8;
        }

    }
}
