cmake --preset net472/x86
cmake --preset net472/x64
cmake --preset net8.0/x86
cmake --preset net8.0/x64

cmake --build --preset net472/x86 --target install
cmake --build --preset net472/x64 --target install
cmake --build --preset net8.0/x86 --target install
cmake --build --preset net8.0/x64 --target install
