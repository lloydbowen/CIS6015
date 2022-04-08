// geometry shader - renders a solid triangle
#version 450
layout (triangles) in;	  	// Position in attribute location 0
layout (triangle_strip, max_vertices = 3) out;

in VS_DATA
{
  vec4 intensity;
  vec2 uv;
} inData[];

out GS_DATA
{
  vec4 intensity;
  vec2 uv;
} outData;


//////////////////////////////////////////////////////////////////
// main()
//////////////////////////////////////////////////////////////////
void main() 
{
    for( int i=0; i<3; i++ )
    {
        // pass through
        outData.intensity = inData[i].intensity; 
        outData.uv = inData[i].uv;
        gl_Position = gl_in[i].gl_Position; 
        EmitVertex();
    }  
}
