#version 330 core
layout (location = 0) out vec4 FragColor;
layout (location = 1) out vec4 BrightColor;


void main() {
    FragColor = vec4(1.0f, 0.75f, 1.0f, 0.8f);
    BrightColor = vec4(FragColor.rgb, 1.0);
}
