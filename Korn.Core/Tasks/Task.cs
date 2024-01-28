/*
 * Scheme:
 * -InitTask                called after build has started
 * -ILTask                  uses for all IL dll's
 * --ILActualTask           uses for all non-bcl dll's
 * ---ILMainTask            uses for target dll
 * -PrepareNativeTask       called after IL part ended. Before calling ilc
 * -ASMTask                 uses for output native dll
 * 
 * Arguments:
 * -Order:
 * --Default: -1
 * --The more, the bigger priority of task and the later it will be called
*/