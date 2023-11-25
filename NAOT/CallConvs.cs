using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface INAOTCallConv;
public class __cdecl : INAOTCallConv;
public class __fastcall : INAOTCallConv;
public class __stdcall : INAOTCallConv;
public class __thiscall : INAOTCallConv;