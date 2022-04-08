#version 450 core

layout(binding = 0) uniform sampler2D ColTexture;

in float Intensity;
in vec2 TexCoord;

out vec4 FragColor; // Color that will be used for the fragment

//////////////////////////////////////////////////////////////////
// main()
//////////////////////////////////////////////////////////////////
void main()
{
    vec4 colour = texture(ColTexture, TexCoord.xy); 

	FragColor = vec4(vec3(colour.xyz * Intensity), 1.0);

    if (Intensity > 0.8)
		colour = vec4(1.0,0.8,0.8,1.0);
	else if (Intensity > 0.5)
		colour = vec4(0.7,0.5,0.5,1.0);
	else if (Intensity > 0.3)
		colour = vec4(0.5,0.3,0.3,1.0);
	else
		colour = vec4(0.2,0.1,0.1,1.0);
	FragColor = colour;

}