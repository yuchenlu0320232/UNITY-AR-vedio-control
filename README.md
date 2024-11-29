⚠️ Due to the update of unity and vuforia, I found during the learning process that some of the previous code has been replaced and deprecated, so some of the code files in the tutorial only work with earlier versions, the specific requirements are slightly different and not applicable to all versions. The versions of unity I use are Unity 2022.3.48f1(64-bit) and vuforia10.27.

⚠️Device requirements for AR testing. I chose Android in Unity export (Huawei's Hongmeng system is also applicable after testing)


VideoCtrl Unity script

The script allows the VideoPlayer component to be controlled through vuforia in Unity, providing the ability to pause, play, stop the video, and set the video to play from the first frame.
The code includes the following functions
1. Set the first frame: Prepare the video and set it to play from the first frame.
2. Play the video: Play the video from the start position.
3. Pause the video: Pause the video and hold the current position.
4. Stop video: Stop video playback and reset.

Steps to use in unity
1. Attach the script to the game object
Create a game object in the scene and attach the VideoCtrl script to the game object.
2. Assign components
In the Inspector window, add the VideoPlayer component you want to control
3. Add video:
Add the Video file to the VideoPlayer component using the Video Clip field.


PinchZoom Unity script

In Unity, the script implements the function of scaling objects through touch gestures (two-finger pinching gestures), which is suitable for touch operations on mobile devices.

Code specification

Check for two touch points per frame (Input.touchCount == 2).
If there are two touch points, the script gets the position of the touch points and calculates the distance between them.

TouchPhase.Began
At the first contact of the two touch points, the initial distance and the initial scaling of the object are recorded.

TouchPhase.Moved
When both touch points are moving, the current touch distance is calculated and the scale is calculated based on the initial distance.
The object is scaled by adjusting transform.localScale.

Supplementary statement
If the scaling of an object needs to be limited, you can add a maximum or minimum scaling limit to the transform.localScale update logic.


For more information, please refer to the official website https://developer.vuforia.com/library/project-migration/how-migrate-unity-project

You will need to register an account to apply for a license and upload an identification image in the Target Manager (the identification image should preferably have contrasting colors)
https://developer.vuforia.com/home
