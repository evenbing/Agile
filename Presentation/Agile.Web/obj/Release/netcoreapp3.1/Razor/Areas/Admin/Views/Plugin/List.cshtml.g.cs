#pragma checksum "D:\Workspace\source\repos\Agile\Presentation\Agile.Web\Areas\Admin\Views\Plugin\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da0b5ce6bf38d5550aba30504237d2a24d440f3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Plugin_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Plugin/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0b5ce6bf38d5550aba30504237d2a24d440f3f", @"/Areas/Admin/Views/Plugin/List.cshtml")]
    public class Areas_Admin_Views_Plugin_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Workspace\source\repos\Agile\Presentation\Agile.Web\Areas\Admin\Views\Plugin\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_ListLayout.cshtml";
    bool b = (bool)ViewBag.IsRestartRequired;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""layui-fluid"">
    <div class=""layui-card"">
        <div class=""layui-card-body"">
            <!-- 表格工具栏 -->
            <form class=""layui-form toolbar"">
                <div class=""layui-form-item"">
                    <div class=""layui-inline"">
                        <label class=""layui-form-label"">插件名称:</label>
                        <div class=""layui-input-inline"">
                            <input name=""username"" class=""layui-input"" placeholder=""输入插件名称"" />
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <label class=""layui-form-label"">插件作者:</label>
                        <div class=""layui-input-inline"">
                            <input name=""nickName"" class=""layui-input"" placeholder=""输入插件作者"" />
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <label class=""layui-form-label"">插件状态:</label>
                   ");
            WriteLiteral("     <div class=\"layui-input-inline\">\r\n                            <select name=\"sex\">\r\n                                <option");
            BeginWriteAttribute("value", " value=\"", 1291, "\"", 1299, 0);
            EndWriteAttribute();
            WriteLiteral(@">请选择</option>
                                <option value=""1"">已安装</option>
                                <option value=""2"">未安装</option>
                                <option value=""3"">已卸载</option>
                            </select>
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <div class=""layui-input-inline"">
                            <button class=""layui-btn icon-btn"" lay-filter=""userTbSearch"" lay-submit><i class=""layui-icon"">&#xe615;</i>搜索</button>
                            <button class=""layui-btn icon-btn"" lay-filter=""restartApplication"" lay-submit><i class=""layui-icon"">&#xe615;</i>重启系统</button>
                        </div>
");
#nullable restore
#line 42 "D:\Workspace\source\repos\Agile\Presentation\Agile.Web\Areas\Admin\Views\Plugin\List.cshtml"
                         if (b)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"layui-form-mid layui-word-aux\">检测插件变更，请重新系统以便于插件生效！</div>\r\n");
#nullable restore
#line 45 "D:\Workspace\source\repos\Agile\Presentation\Agile.Web\Areas\Admin\Views\Plugin\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </form>\r\n            <!-- 数据表格 -->\r\n            <table id=\"userTable\" lay-filter=\"userTable\"></table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- 表格操作列 -->
    <script type=""text/html"" id=""userTbBar"">
        {{#  if(d.state===""未安装""){ }}
        <a class=""layui-btn layui-btn-warm layui-btn-xs"" lay-event=""install"">安装</a>
        {{#  } else { }}
    <a class=""layui-btn layui-btn-warm layui-btn-xs"" lay-event=""uninstall"">卸载</a>
        {{#  } }}
        <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""delete"">删除</a>
    </script>

    <script type=""text/html"" id=""toolbar"">
        <button lay-event=""add"" class=""layui-btn layui-btn-sm icon-btn""><i class=""layui-icon"">&#xe654;</i>安装插件</button>
    </script>

    <script>
        layui.use(['layer', 'form', 'table', 'util', 'admin', 'xmSelect'], function () {
            var $ = layui.jquery;
            var layer = layui.layer;
            var form = layui.form;
            var table = layui.table;
            var util = layui.util;
            var admin = layui.admin;
            var xmSelect = layui.xmSelect;
            /* 渲染表格 */
            var insTb = tab");
                WriteLiteral(@"le.render({
                elem: '#userTable',
                url: '/admin/plugin/getdata',
                page: true,
                toolbar: '#toolbar',
                cellMinWidth: 100,
                cols: [[
                    { type: 'checkbox' },
                    { type: 'numbers' },
                    { field: 'systemName', title: 'SystemName', sort: true },
                    { field: 'state', title: 'State', sort: true },
                    { field: 'author', title: 'Author', sort: true },
                    { field: 'description', title: 'Description', sort: true },
                    { title: '操作', toolbar: '#userTbBar', align: 'center', minWidth: 200 }
                ]]
            });

            /* 表格搜索 */
            form.on('submit(userTbSearch)', function (data) {
                //insTb.reload({ where: data.field, page: { curr: 1 } });

                layer.msg('开发中...', { icon: 6 });
                return false;
            });

            form.");
                WriteLiteral(@"on('submit(restartApplication)', function (data) {
                //insTb.reload({ where: data.field, page: { curr: 1 } });

                $.get('/admin/common/restartApplication', '', function (res) {  // 实际项目这里url可以是mData?'user/update':'user/add'
                    console.log(res);
                });
                return false;
            });

            form.on('submit(applyChanges)', function (data) {
                //insTb.reload({ where: data.field, page: { curr: 1 } });

                $.get('/admin/plugin/applyChanges', '', function (res) {  // 实际项目这里url可以是mData?'user/update':'user/add'
                    console.log(res);
                });
                return false;
            });

            /* 表格工具条点击事件 */
            table.on('tool(userTable)', function (obj) {
                if (obj.event === 'edit') { // 修改
                    showEditModel(obj.data);
                } else if (obj.event === 'del') { // 删除
                    doDel(obj);
             ");
                WriteLiteral(@"   } else if (obj.event === 'reset') { // 重置密码
                    resetPsw(obj);
                }
                var systemName = obj.data.systemName;
                if (obj.event === 'install') {
                    $.get('/admin/plugin/install', { systemName: systemName }, function (data) {  // 实际项目这里url可以是mData?'user/update':'user/add'
                        layer.msg(data, { icon: 1 });
                        table.reload();
                    });
                }
                if (obj.event === 'uninstall') {
                    $.get('/admin/plugin/uninstall', { systemName: systemName }, function (res) {  // 实际项目这里url可以是mData?'user/update':'user/add'
                        layer.msg(data, { icon: 1 });
                        table.reload();
                    });
                }
                if (obj.event === 'delete') {
                    $.get('/admin/plugin/delete', { systemName: systemName }, function (res) {  // 实际项目这里url可以是mData?'user/update':'user/add'
       ");
                WriteLiteral(@"                 layer.msg(data, { icon: 1 });
                        table.reload();
                    });
                }
            });

            /* 表格头工具栏点击事件 */
            table.on('toolbar(userTable)', function (obj) {
                if (obj.event === 'add') { // 添加
                    showEditModel();
                } else if (obj.event === 'del') { // 删除
                    layer.msg('开发中...', { icon: 6 });
                }
            });

            /* 显示表单弹窗 */
            function showEditModel(mData) {
                //layer.msg('开发中...', { icon: 6 });
                admin.open({
                    type: 2,
                    title: '安装插件',
                    content: ""/admin/plugin/UploadPlugins"",
                    success: function (layero, dIndex) {

                    }
                });

            }

            /* 删除 */
            function doDel(obj) {
                layer.msg('开发中...', { icon: 6 });
            }
        });
   ");
                WriteLiteral(" </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591