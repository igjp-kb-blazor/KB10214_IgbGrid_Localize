﻿using IgniteUI.Blazor.Controls;

namespace KB10214_IgbGrid_Localize;

#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
public static class GridResourceStrings
{
    public static readonly IgbGridResourceStrings JA = new()
    {
        Igx_grid_groupByArea_message = "列ヘッダーをここへドラッグして列をグループ化します。",
        Igx_grid_emptyFilteredGrid_message = "レコードは見つかりませんでした。",
        Igx_grid_emptyGrid_message = "グリッドにデータがありません。",
        Igx_grid_filter = "フィルター",
        Igx_grid_filter_row_close = "閉じる",
        Igx_grid_filter_row_reset = "リセット",
        Igx_grid_filter_row_placeholder = "フィルター値の追加",
        Igx_grid_filter_row_boolean_placeholder = "すべて",
        Igx_grid_filter_row_date_placeholder = "日付の選択",
        Igx_grid_filter_row_time_placeholder = "ピックアップ時間",
        Igx_grid_filter_operator_and = "And",
        Igx_grid_filter_operator_or = "Or",
        Igx_grid_complex_filter = "高度なフィルター",
        Igx_grid_filter_contains = "を含む",
        Igx_grid_filter_doesNotContain = "含まない",
        Igx_grid_filter_startsWith = "で始まる",
        Igx_grid_filter_endsWith = "で終わる",
        Igx_grid_filter_equals = "等しい",
        Igx_grid_filter_doesNotEqual = "等しくない",
        Igx_grid_filter_empty = "空",
        Igx_grid_filter_notEmpty = "空以外",
        Igx_grid_filter_null = "Null",
        Igx_grid_filter_notNull = "Null 以外",
        Igx_grid_filter_before = "前",
        Igx_grid_filter_after = "後",
        Igx_grid_filter_at = "特定の時間",
        Igx_grid_filter_not_at = "特定の時間以外",
        Igx_grid_filter_at_before = "以前",
        Igx_grid_filter_at_after = "以後",
        Igx_grid_filter_today = "今日",
        Igx_grid_filter_yesterday = "昨日",
        Igx_grid_filter_thisMonth = "今月",
        Igx_grid_filter_lastMonth = "先月",
        Igx_grid_filter_nextMonth = "翌月",
        Igx_grid_filter_thisYear = "今年",
        Igx_grid_filter_lastYear = "昨年",
        Igx_grid_filter_nextYear = "翌年",
        Igx_grid_filter_greaterThan = "より大きい",
        Igx_grid_filter_lessThan = "より小さい",
        Igx_grid_filter_greaterThanOrEqualTo = "以上",
        Igx_grid_filter_lessThanOrEqualTo = "以下",
        Igx_grid_filter_true = "True",
        Igx_grid_filter_false = "False",
        Igx_grid_filter_all = "すべて",
        Igx_grid_filter_condition_placeholder = "フィルターの選択",
        Igx_grid_summary_count = "カウント",
        Igx_grid_summary_min = "最小",
        Igx_grid_summary_max = "最大",
        Igx_grid_summary_sum = "合計",
        Igx_grid_summary_average = "平均",
        Igx_grid_summary_earliest = "最も早い日",
        Igx_grid_summary_latest = "最も遅い日",
        Igx_grid_excel_filter_moving_left = "左へ移動",
        Igx_grid_excel_filter_moving_left_short = "左",
        Igx_grid_excel_filter_moving_right = "右へ移動",
        Igx_grid_excel_filter_moving_right_short = "右",
        Igx_grid_excel_filter_moving_header = "移動",
        Igx_grid_excel_filter_sorting_asc = "昇順",
        Igx_grid_excel_filter_sorting_asc_short = "昇",
        Igx_grid_excel_filter_sorting_desc = "降順",
        Igx_grid_excel_filter_sorting_desc_short = "降",
        Igx_grid_excel_filter_sorting_header = "並べ替え",
        Igx_grid_excel_filter_clear = "列フィルターのクリア",
        Igx_grid_excel_custom_dialog_add = "フィルターの追加",
        Igx_grid_excel_custom_dialog_clear = "フィルターのクリア",
        Igx_grid_excel_custom_dialog_header = "列のカスタム自動フィルター: ",
        Igx_grid_excel_cancel = "キャンセル",
        Igx_grid_excel_apply = "適用",
        Igx_grid_excel_search_placeholder = "検索",
        Igx_grid_excel_select_all = "すべて選択",
        Igx_grid_excel_select_all_search_results = "すべての検索結果を選択",
        Igx_grid_excel_add_to_filter = "現在の選択をフィルターに追加",
        Igx_grid_excel_blanks = "(空)",
        Igx_grid_excel_hide = "列の非表示",
        Igx_grid_excel_show = "列の表示",
        Igx_grid_excel_pin = "列のピン固定",
        Igx_grid_excel_unpin = "列のピン固定解除",
        Igx_grid_excel_select = "列の選択",
        Igx_grid_excel_deselect = "列選択の解除",
        Igx_grid_excel_text_filter = "テキスト フィルター",
        Igx_grid_excel_number_filter = "数値フィルター",
        Igx_grid_excel_date_filter = "日付フィルター",
        Igx_grid_excel_boolean_filter = "ブール値フィルター",
        Igx_grid_excel_currency_filter = "通貨フィルター",
        Igx_grid_excel_custom_filter = "カスタム フィルター...",
        Igx_grid_excel_no_matches = "一致がありませんでした",
        Igx_grid_advanced_filter_title = "高度なフィルター",
        Igx_grid_advanced_filter_and_group = "\"And\" グループ",
        Igx_grid_advanced_filter_or_group = "\"Or\" グループ",
        Igx_grid_advanced_filter_end_group = "End グループ",
        Igx_grid_advanced_filter_create_and_group = "\"And\" グループの作成",
        Igx_grid_advanced_filter_create_or_group = "\"Or\" グループの作成",
        Igx_grid_advanced_filter_and_label = "and",
        Igx_grid_advanced_filter_or_label = "or",
        Igx_grid_advanced_filter_add_condition = "条件",
        Igx_grid_advanced_filter_ungroup = "グループ解除",
        Igx_grid_advanced_filter_delete = "削除",
        Igx_grid_advanced_filter_delete_filters = "フィルターの削除",
        Igx_grid_advanced_filter_initial_text = "\"And\" あるいは \"Or\" にリンクされた条件のグループの作成から始めます。",
        Igx_grid_advanced_filter_column_placeholder = "列の選択",
        Igx_grid_advanced_filter_value_placeholder = "値",
        Igx_grid_pinned_row_indicator = "固定済み",
        Igx_grid_hiding_check_all_label = "すべて表示",
        Igx_grid_hiding_uncheck_all_label = "すべて非表示",
        Igx_grid_pinning_check_all_label = "すべて固定",
        Igx_grid_pinning_uncheck_all_label = "すべて固定解除",
        Igx_grid_row_edit_btn_done = "完了",
        Igx_grid_row_edit_btn_cancel = "キャンセル",
        Igx_grid_toolbar_actions_filter_prompt = "列リストのフィルター",
        Igx_grid_toolbar_pinning_button_tooltip = "列ピン固定のドロップダウンを開く",
        Igx_grid_toolbar_hiding_button_tooltip = "列非表示のドロップダウンを開く",
        Igx_grid_toolbar_pinning_title = "ピン固定列",
        Igx_grid_toolbar_hiding_title = "表示列",
        Igx_grid_toolbar_advanced_filtering_button_tooltip = "高度なフィルタリング ダイアログを開く",
        Igx_grid_toolbar_advanced_filtering_button_label = "高度なフィルタリング",
        Igx_grid_toolbar_exporter_button_tooltip = "エクスポーターのドロップダウンを開く",
        Igx_grid_toolbar_exporter_button_label = "エクスポート",
        Igx_grid_toolbar_exporter_excel_entry_text = "Excel へエクスポート",
        Igx_grid_toolbar_exporter_csv_entry_text = "CSV へのエクスポート",
        Igx_grid_groupByArea_select_message = "フィールド名 {0}、値 {1} のグループ内のすべての行を選択します。",
        Igx_grid_groupByArea_deselect_message = "フィールド名 {0}、値 {1} のグループ内のすべての行を選択解除します。",
        Igx_grid_snackbar_addrow_label = "行が追加されました",
        Igx_grid_snackbar_addrow_actiontext = "表示",
        Igx_grid_actions_edit_label = "編集",
        Igx_grid_actions_add_label = "追加",
        Igx_grid_add_row_label = "行の追加",
        Igx_grid_actions_add_child_label = "子の追加",
        Igx_grid_actions_delete_label = "削除",
        Igx_grid_actions_pin_label = "固定",
        Igx_grid_actions_unpin_label = "固定解除",
        Igx_grid_actions_jumpUp_label = "上へ移動",
        Igx_grid_actions_jumpDown_label = "下へ移動",
        Igx_grid_pivot_date_dimension_total = "すべての期間",
        Igx_grid_pivot_aggregate_count = "カウント",
        Igx_grid_pivot_aggregate_min = "最小値",
        Igx_grid_pivot_aggregate_max = "最大値",
        Igx_grid_pivot_aggregate_sum = "合計",
        Igx_grid_pivot_aggregate_avg = "平均",
        Igx_grid_pivot_aggregate_date_latest = "最新の日付",
        Igx_grid_pivot_aggregate_date_earliest = "最も早い日付",
        Igx_grid_pivot_aggregate_time_latest = "最新の時刻",
        Igx_grid_pivot_aggregate_time_earliest = "最も早い時刻",
        Igx_grid_pivot_empty_row_drop_area = "行フィールドをここにドロップします。",
        Igx_grid_pivot_empty_column_drop_area = "列フィールドをここにドロップします。",
        Igx_grid_pivot_empty_filter_drop_area = "フィルター フィールドをここにドロップします。",
        Igx_grid_pivot_empty_value_drop_area = "値フィールドをここにドロップします。",
        Igx_grid_pivot_row_drop_chip = "ここにドロップして行として使用",
        Igx_grid_pivot_column_drop_chip = "ここにドロップして列として使用",
        Igx_grid_pivot_filter_drop_chip = "ここにドロップしてフィルターとして使用",
        Igx_grid_pivot_value_drop_chip = "ここにドロップして値として使用",
        Igx_grid_pivot_selector_filters = "フィルター",
        Igx_grid_pivot_selector_rows = "行",
        Igx_grid_pivot_selector_columns = "列",
        Igx_grid_pivot_selector_values = "値",
        Igx_grid_pivot_selector_panel_empty = "ここに項目をドラッグして",
        Igx_grid_pivot_empty_message = "ピボット グリッドにはディメンションと値がありません。",
        Igx_grid_required_validation_error = "このフィールドは必須フィールドです。",
        Igx_grid_min_validation_error = "{0} 以上の値を入力してください",
        Igx_grid_max_validation_error = "{0} 以下の値を入力してください",
        Igx_grid_min_length_validation_error = "入力の長さは少なくとも {0} 文字である必要があります",
        Igx_grid_max_length_validation_error = "入力の長さは {0} 文字以下である必要があります",
        Igx_grid_email_validation_error = "有効なメール アドレスを入力してください",
        Igx_grid_pattern_validation_error = "入力が所定のパターンに一致しません",
        Igx_grid_pivot_no_aggregator = "{0} の有効なアグリゲーターが見つかりません。有効な aggregatorName または aggregator を設定してください。"
    };
}
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
