// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once



#include <CppUnitTest.h>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

#define DECLARE_TEST(method) \
	TEST_CLASS(method##_Class) \
	{\
	public:\
		TEST_METHOD(method##_Test)

