//-----------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCTABL {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.6.100.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class S02_RowRops_QueryPositionSuccess_TestSuite : PtfTestClassBase {
        
        public S02_RowRops_QueryPositionSuccess_TestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "2000000");
        }
        
        #region Expect Delegates
        public delegate void CheckMAPIHTTPTransportSupportedDelegate1(bool isSupported);
        
        public delegate void RopQueryPositionResponseDelegate1(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount);
        #endregion
        
        #region Event Metadata
        static System.Reflection.MethodBase CheckMAPIHTTPTransportSupportedInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckMAPIHTTPTransportSupported", typeof(bool).MakeByRefType());
        
        static System.Reflection.EventInfo RopQueryPositionResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "RopQueryPositionResponse");
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter IMS_OXCTABLAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.IMS_OXCTABLAdapterInstance = ((Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter))));
            this.Manager.Subscribe(RopQueryPositionResponseInfo, this.IMS_OXCTABLAdapterInstance);
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite() {
            this.Manager.BeginTest("MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite");
            this.Manager.Comment("reaching state \'S0\'");
            bool temp0;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp0);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp0);
            this.Manager.Comment("reaching state \'S1\'");
            int temp5 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S02_RowRops_QueryPositionSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S02_RowRops_QueryPositionSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp5 == 0)) {
                this.Manager.Comment("reaching state \'S6\'");
                goto label0;
            }
            if ((temp5 == 1)) {
                this.Manager.Comment("reaching state \'S7\'");
                this.Manager.Comment("executing step \'call InitializeTable(CONTENT_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType)(0)));
                this.Manager.Comment("reaching state \'S12\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S15\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp1;
                this.Manager.Comment("executing step \'call RopSetColumns(1,False,False,False)\'");
                temp1 = this.IMS_OXCTABLAdapterInstance.RopSetColumns(1u, false, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R831");
                this.Manager.Checkpoint("MS-OXCTABL_R45");
                this.Manager.Comment("reaching state \'S18\'");
                this.Manager.Comment("checking step \'return RopSetColumns/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp1, "return of RopSetColumns, state S18");
                this.Manager.Comment("reaching state \'S21\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp2;
                this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                temp2 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                this.Manager.Checkpoint("MS-OXCTABL_R526");
                this.Manager.Comment("reaching state \'S24\'");
                this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp2, "return of RopCreateBookmark, state S24");
                this.Manager.Comment("reaching state \'S26\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp3;
                this.Manager.Comment("executing step \'call RopRestrict(1,True,False,False)\'");
                temp3 = this.IMS_OXCTABLAdapterInstance.RopRestrict(1u, true, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R834");
                this.Manager.Comment("reaching state \'S28\'");
                this.Manager.Comment("checking step \'return RopRestrict/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp3, "return of RopRestrict, state S28");
                this.Manager.Comment("reaching state \'S30\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp4;
                this.Manager.Comment("executing step \'call RopQueryPosition()\'");
                temp4 = this.IMS_OXCTABLAdapterInstance.RopQueryPosition();
                this.Manager.Checkpoint("MS-OXCTABL_R846");
                this.Manager.Comment("reaching state \'S32\'");
                this.Manager.Comment("checking step \'return RopQueryPosition/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp4, "return of RopQueryPosition, state S32");
                this.Manager.Comment("reaching state \'S34\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S02_RowRops_QueryPositionSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteRopQueryPositionResponseChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S36\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S02_RowRops_QueryPositionSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteRopQueryPositionResponseChecker)));
                }
                goto label0;
            }
            throw new InvalidOperationException("never reached");
        label0:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuiteRopQueryPositionResponseChecker(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount) {
            this.Manager.Comment("checking step \'event RopQueryPositionResponse(BEGIN,True)\'");
            try {
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition)(0)), cursorPosition, "cursorPosition of RopQueryPositionResponse, state S34");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRowCount, "isRowCount of RopQueryPositionResponse, state S34");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R491, MS-OXCTABL_R453");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R491");
            this.Manager.Checkpoint("MS-OXCTABL_R453");
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1() {
            this.Manager.BeginTest("MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1");
            this.Manager.Comment("reaching state \'S2\'");
            bool temp6;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp6);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp6);
            this.Manager.Comment("reaching state \'S3\'");
            int temp11 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S02_RowRops_QueryPositionSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S02_RowRops_QueryPositionSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp11 == 0)) {
                this.Manager.Comment("reaching state \'S8\'");
                this.Manager.Comment("executing step \'call InitializeTable(CONTENT_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType)(0)));
                this.Manager.Comment("reaching state \'S13\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S16\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp7;
                this.Manager.Comment("executing step \'call RopSetColumns(1,False,False,False)\'");
                temp7 = this.IMS_OXCTABLAdapterInstance.RopSetColumns(1u, false, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R831");
                this.Manager.Checkpoint("MS-OXCTABL_R45");
                this.Manager.Comment("reaching state \'S19\'");
                this.Manager.Comment("checking step \'return RopSetColumns/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp7, "return of RopSetColumns, state S19");
                this.Manager.Comment("reaching state \'S22\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp8;
                this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                temp8 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                this.Manager.Checkpoint("MS-OXCTABL_R526");
                this.Manager.Comment("reaching state \'S25\'");
                this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp8, "return of RopCreateBookmark, state S25");
                this.Manager.Comment("reaching state \'S27\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp9;
                this.Manager.Comment("executing step \'call RopSortTable(1,True,False,False,False,False,False,False)\'");
                temp9 = this.IMS_OXCTABLAdapterInstance.RopSortTable(1u, true, false, false, false, false, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R447");
                this.Manager.Comment("reaching state \'S29\'");
                this.Manager.Comment("checking step \'return RopSortTable/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp9, "return of RopSortTable, state S29");
                this.Manager.Comment("reaching state \'S31\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp10;
                this.Manager.Comment("executing step \'call RopQueryPosition()\'");
                temp10 = this.IMS_OXCTABLAdapterInstance.RopQueryPosition();
                this.Manager.Checkpoint("MS-OXCTABL_R846");
                this.Manager.Comment("reaching state \'S33\'");
                this.Manager.Comment("checking step \'return RopQueryPosition/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp10, "return of RopQueryPosition, state S33");
                this.Manager.Comment("reaching state \'S35\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S02_RowRops_QueryPositionSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1RopQueryPositionResponseChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S37\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S02_RowRops_QueryPositionSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1RopQueryPositionResponseChecker)));
                }
                goto label1;
            }
            if ((temp11 == 1)) {
                this.Manager.Comment("reaching state \'S9\'");
                goto label1;
            }
            throw new InvalidOperationException("never reached");
        label1:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1RopQueryPositionResponseChecker(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount) {
            this.Manager.Comment("checking step \'event RopQueryPositionResponse(BEGIN,True)\'");
            try {
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition)(0)), cursorPosition, "cursorPosition of RopQueryPositionResponse, state S35");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRowCount, "isRowCount of RopQueryPositionResponse, state S35");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R491");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R491");
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite2() {
            this.Manager.BeginTest("MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite2");
            this.Manager.Comment("reaching state \'S4\'");
            bool temp12;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp12);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp12);
            this.Manager.Comment("reaching state \'S5\'");
            int temp14 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S02_RowRops_QueryPositionSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite2CheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S02_RowRops_QueryPositionSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite2CheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp14 == 0)) {
                this.Manager.Comment("reaching state \'S10\'");
                this.Manager.Comment("executing step \'call InitializeTable(RULES_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType.RULES_TABLE);
                this.Manager.Comment("reaching state \'S14\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S17\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp13;
                this.Manager.Comment("executing step \'call RopQueryPosition()\'");
                temp13 = this.IMS_OXCTABLAdapterInstance.RopQueryPosition();
                this.Manager.Checkpoint("MS-OXCTABL_R845");
                this.Manager.Comment("reaching state \'S20\'");
                this.Manager.Comment("checking step \'return RopQueryPosition/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp13, "return of RopQueryPosition, state S20");
                this.Manager.Comment("reaching state \'S23\'");
                goto label2;
            }
            if ((temp14 == 1)) {
                this.Manager.Comment("reaching state \'S11\'");
                goto label2;
            }
            throw new InvalidOperationException("never reached");
        label2:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite2CheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S5");
        }
        
        private void MSOXCTABL_S02_RowRops_QueryPositionSuccess_TestSuite2CheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S5");
        }
        #endregion
    }
}