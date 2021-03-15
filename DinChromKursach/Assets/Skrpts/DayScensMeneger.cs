using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayScensMeneger : MonoBehaviour
{
    [Range(0,1)]
    public float TimeOfDay;
    public float DayDuration = 120f;

    public AnimationCurve SunCurve;
    public AnimationCurve MoonCurve;
    public AnimationCurve SkyBoxCurve;

    public AudioSource audioDayOrNight;
    public AudioClip day;
    public AudioClip night;

    public Material DaySkyBox;
    public Material NightSkyBox;

    public Light Sun;
    public Light Moon;
    public ParticleSystem stars;

    private float SunIntensity;
    private float MoonIntensity;

    private void Start()
    {
        SunIntensity = Sun.intensity;
        MoonIntensity = Moon.intensity;
    }
    static bool _chekday = false;
    private void Update()
    {
        TimeOfDay += Time.deltaTime / DayDuration;
        if (TimeOfDay >= 1)
        {
            TimeOfDay -= 1;
        }
        if (TimeOfDay >= 0.53)
        {
            stars.maxParticles = 200;
            audioDayOrNight.clip = night;
        }
        if (TimeOfDay <= 0.45)
        {
            stars.maxParticles = 0; 
            audioDayOrNight.clip = day;
        }
        if (audioDayOrNight.isPlaying == false)
            audioDayOrNight.Play();
        RenderSettings.skybox.Lerp(NightSkyBox, DaySkyBox, SkyBoxCurve.Evaluate(TimeOfDay));
        DynamicGI.UpdateEnvironment();

        Sun.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f, 180, 0);
        Moon.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f + 180f, 180, 0);

        Sun.intensity = SunIntensity * SunCurve.Evaluate(TimeOfDay);
        Moon.intensity = MoonIntensity * MoonCurve.Evaluate(TimeOfDay);
    }
}
