### Date created
8/08/2019

### Versions:
GoogleVR SDK version 1.60.0
Unity version 2019.2.0f1 Personal

### Project Title
A night at the museum

### Description
Udacity VR Developer NAno Degree Project 5 Submission
David Long
c.david.long@gmail.com
10/19/2017 submission

I've taken a base asset (from the Unity Asset store) and added a set of 5 viewing stations and movement mechanics to allow navigation through a museum scene by night.

The 5 stations are a mix of audio, video and images presenting views of the development of and possibilities with data visualization using virtual reality.

There is a single scene called "Start Scene" to view the  museum.

I've kept the player's and world's game objects logically nested.

I went through a prolonged development on this project as I was returning after a lengthy break from the course while recovering from a fractured leg. I revisisted much of the material and had to relearn some items. I was happy to see the guidance on Unity and Google VR versions be explicitly called out as I had issues with it at the start of the development.

I've included a video in my zip file of the experience titled "David_Long_A_night_at_the_museum_Project_5.mp4"

Some of the areas that I had to iterate on include:

1. Cleaning out the garbage - I had usused  meshes and some raycasters hanging around. I removed them and I feel this made a small improvement when I deployed to my device. Then again it could be a placebo effect! It's certainly a practice I need to be more aware of.

2. I changed the videos from loading on initialization to loading when triggered and enabled. - This definitely made a big improvement.

3. I modified the placement of the colliders placing them under the floor of the room at each station and used the trigger under the player object in conjunction with the script reviewed with you to enable the videos. - This was a further experience improvement as there was no more interference with the movement mechanic. Previously my triggers would block the raycastIndicator object from certain placement.

### Credits
https://visualmatters.com/short-history-data-visualization/
https://hackernoon.com/6-ways-virtual-reality-will-transform-big-data-visualizations-8554e2203cbb
Utilzied Assets Modern Gallery by Tirgames assets
iTween by Pixelplacement



