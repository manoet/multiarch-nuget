add_library(
    NativeLibA
    STATIC
    NativeLibA.h
    NativeLibA.cpp)

target_include_directories(
    NativeLibA
    PUBLIC
    ${CMAKE_CURRENT_SOURCE_DIR})