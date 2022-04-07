#version 450 core

layout(location = 0) in vec3 Position_VS_in; //Location 1
layout(location = 1) in vec2 TexCoord_VS_in; //Location 2 
layout(location = 2) in vec3 Normal_VS_in; //Location 3

uniform mat4 gWorld;

out vec3 WorldPos_CS_in; //WorldPos
out vec2 TexCoord_CS_in; //TextCoord
out vec3 Normal_CS_in; //Normal

//////////////////////////////////////////////////////////////////
// main()
//////////////////////////////////////////////////////////////////
void main()
{
    //this isnt working
    WorldPos_CS_in = (gWorld * vec4(Position_VS_in, 1.0)).xyz;
    TexCoord_CS_in = TexCoord_VS_in;
    Normal_CS_in = (gWorld * vec4(Normal_VS_in, 0.0)).xyz;
}