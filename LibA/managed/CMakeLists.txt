add_library(
    LibA
    SHARED
    LibA.h
    LibA.cpp
    AssemblyInfo.cpp)

target_link_libraries(
    LibA
    PRIVATE
    NativeLibA)

set_target_properties(
    LibA
    PROPERTIES
    VS_GLOBAL_ROOTNAMESPACE "LibA"
    VS_GLOBAL_KEYWORD "ManagedCProj"
    VS_GLOBAL_CLRSupport "${NET_CLR_SUPPORT}"
    DOTNET_TARGET_FRAMEWORK "${NET_FRAMEWORK}"
    COMMON_LANGUAGE_RUNTIME "${NET_CLR}"
    OUTPUT_NAME "LibA"
    DEBUG_POSTFIX ""
    RELEASE_POSTFIX "")

string(REPLACE "/EHsc" "" CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS}")
string(REPLACE "/RTC1" "" CMAKE_CXX_FLAGS_DEBUG "${CMAKE_CXX_FLAGS_DEBUG}")

install(
    TARGETS LibA
    DESTINATION .)