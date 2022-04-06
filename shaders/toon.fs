#version 450 core

layout(binding = 1) uniform sampler2D ColTexture;

in float Intensity;
in vec2 TexCoord;

out vec3 FragColor; // Color that will be used for the fragment

//////////////////////////////////////////////////////////////////
// main()
//////////////////////////////////////////////////////////////////
void main()
{
    vec4 colour = texture(ColTexture, TexCoord.xy); 

	FragColor = vec4(vec3(colour.xyz * Intensity), 1.0);

    if (Intensity > 0.75)
		colour = vec4(1.0,0.5,0.5,1.0);
	else if (Intensity > 0.5)
		colour = vec4(0.6,0.3,0.3,1.0);
	else if (Intensity > 0.25)
		colour = vec4(0.4,0.2,0.2,1.0);
	else
		colour = vec4(0.2,0.1,0.1,1.0);
	FragColor = colour;

}