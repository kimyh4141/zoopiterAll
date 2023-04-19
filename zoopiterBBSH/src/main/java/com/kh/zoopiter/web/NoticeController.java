package com.kh.zoopiter.web;

import com.kh.zoopiter.domain.BBSH.svc.BBSHSVC;
import com.kh.zoopiter.domain.common.file.svc.UploadFileSVC;
import com.kh.zoopiter.domain.common.paging.FindCriteria;
import com.kh.zoopiter.domain.entity.BBSH;
import com.kh.zoopiter.domain.entity.UploadFile;
import com.kh.zoopiter.web.common.AttachFileType;
import com.kh.zoopiter.web.form.BBSH.DetailForm;
import com.kh.zoopiter.web.form.BBSH.ListForm;
import com.kh.zoopiter.web.form.BBSH.SaveForm;
import com.kh.zoopiter.web.form.BBSH.UpdateForm;
import jakarta.validation.Valid;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.BeanUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Slf4j
@Controller
@RequestMapping("/BBSH")
@RequiredArgsConstructor
public class NoticeController {

  private final BBSHSVC BBSHSVC;
  //  private final CodeDAO codeDAO;
  private final UploadFileSVC uploadFileSVC;

  @Autowired
  @Qualifier("fc10") //동일한 타입의 객체가 여러개있을때 빈이름을 명시적으로 지정해서 주입받을때
  private FindCriteria fc;
//
//  //게시판 코드,디코드 가져오기
//  @ModelAttribute("classifier")
//  public List<Code> classifier(){
//    return codeDAO.findCodesByPcodeId("B0101");
//  }
//
//  @ModelAttribute("bbsTitle")
//  public Map<String,String> bbsTitle(){
//    List<Code> codes = codeDAO.findCodesByPcodeId("B0101");
//    Map<String,String> btitle = new HashMap<>();
//    for (Code code : codes) {
//      btitle.put(code.getCodeId(), code.getDecode());
//    }
//    return btitle;
//  }

  // 등록양식
  @GetMapping("/add")
  public String saveForm(Model model) {
    model.addAttribute("saveForm", new SaveForm());
    return "BBSH/saveForm";
  }

//  public String addForm(
//      Model model,
//      @RequestParam(required = false) Optional<String> category,
//      HttpSession session) {
//
//    String cate = getCategory(category);
//
//    LoginMember loginMember = (LoginMember) session.getAttribute(SessionConst.LOGIN_MEMBER);
//
//    AddForm addForm = new AddForm();
//    addForm.setEmail(loginMember.getEmail());
//    addForm.setNickname(loginMember.getNickname());
//    model.addAttribute("addForm", addForm);
//    model.addAttribute("category", cate);
//
//    return "bbs/addForm";

//  }

  // 등록처리
  @PostMapping("/add")
  public String save(
      @Valid @ModelAttribute SaveForm saveForm,
      BindingResult bindingResult,
      RedirectAttributes redirectAttributes
  ) {
    log.info("saveForm={}", saveForm);

    // 데이터 검증
    // 어노테이션 기반 검증
    if (bindingResult.hasErrors()) {
      log.info("bindingResult={}", bindingResult);
      return "BBSH/saveForm";
    }

    // 등록
    BBSH bbsh = new BBSH();
//    bbsh.setBbshId(saveForm.getBbshId());
    bbsh.setBhTitle(saveForm.getBhTitle());
    bbsh.setBhContent(saveForm.getBhContent());
    bbsh.setPetType(saveForm.getPetType());
    bbsh.setBhStar(saveForm.getBhStar());
//    bbsh.setBhAttach(saveForm.getAttachFile());
//    BBSH.setAuthor(saveForm.getAuthor());
//    BBSH.setHit(saveForm.getHit());
//    BBSH.setCDate(saveForm.getCDate());
//    BBSH.setUDate(saveForm.getUDate());

    // 파일첨부에 대한 메타정보추출 & 물리파일저장
//    UploadFile attachFile = uploadFileSVC.convert(saveForm.getAttachFile(), AttachFileType.F010201);
    List<UploadFile> imageFiles = uploadFileSVC.convert(saveForm.getImageFiles(), AttachFileType.F010202);
//    if(attachFile != null) imageFiles.add(attachFile);

    Long saveId = BBSHSVC.save(bbsh, imageFiles);
    redirectAttributes.addAttribute("bbshId", saveId);

    return "redirect:/BBSH/{bbshId}/detail";
  }

  // 조회
  @GetMapping("/{bbshId}/detail")
  public String findById(
      @PathVariable("bbshId") Long bbshId,
      Model model
  ) {
    Optional<BBSH> findedNotice = BBSHSVC.findById(bbshId);
    BBSH bbsh = findedNotice.orElseThrow();

    DetailForm detailForm = new DetailForm();
    detailForm.setBbshId(bbsh.getBbshId());
    detailForm.setBhTitle(bbsh.getBhTitle());
    detailForm.setBhContent(bbsh.getBhContent());
    detailForm.setPetType(bbsh.getPetType());
    detailForm.setBhHit(bbsh.getBhHit());
    detailForm.setBhStar(bbsh.getBhStar());
//    detailForm.setAuthor(BBSH.getAuthor());
    detailForm.setBhCdate(bbsh.getBhCdate());
    detailForm.setBhUdate(bbsh.getBhUdate());

    //첨부파일조회
    List<UploadFile> imagedFiles = uploadFileSVC.findFilesByCodeWithRid(AttachFileType.F010202, bbshId);
    if (imagedFiles.size() > 0) {
      log.info("ImagedFiles={}", imagedFiles);
      model.addAttribute("imagedFiles", imagedFiles);
    }
//    detailForm.setImagedFiles(imagedFiles);

    model.addAttribute("detailForm", detailForm);
    return "BBSH/detailForm";
  }

  //   수정양식
  @GetMapping("/{bbshId}/edit")
  public String updateForm(
      @PathVariable("bbshId") Long bbshId,
      Model model
  ) {
    Optional<BBSH> findedNotice = BBSHSVC.findById(bbshId);
    BBSH bbsh = findedNotice.orElseThrow();

    UpdateForm updateForm = new UpdateForm();
    updateForm.setBhStar(bbsh.getBhStar());
    updateForm.setPetType(bbsh.getPetType());
    updateForm.setBhTitle(bbsh.getBhTitle());
    updateForm.setBhContent(bbsh.getBhContent());

    model.addAttribute("updateForm", updateForm);


    //첨부파일조회
    List<UploadFile> imagedFiles = uploadFileSVC.findFilesByCodeWithRid(AttachFileType.F010202, bbshId);
    if (imagedFiles.size() > 0) {
      log.info("ImagedFiles={}", imagedFiles);
      model.addAttribute("imagedFiles", imagedFiles);
    }
    model.addAttribute("bbshId", bbshId);
    return "BBSH/updateForm";
  }

  // 수정
  @PostMapping("/{bbshId}/edit")
  public String update(
      @PathVariable("bbshId") Long bbshId,
      @Valid @ModelAttribute UpdateForm updateForm,
      BindingResult bindingResult,
      RedirectAttributes redirectAttributes
  ) {
    // 데이터 검증
    if (bindingResult.hasErrors()) {
      log.info("bindingResult={}", bindingResult);
      return "BBSH/updateForm";
    }

    // 정상처리
    BBSH bbsh = new BBSH();
    bbsh.setBbshId(bbshId);
    bbsh.setBhTitle(updateForm.getBhTitle());
    bbsh.setBhContent(updateForm.getBhContent());
    bbsh.setBhStar(updateForm.getBhStar());
    bbsh.setPetType(updateForm.getPetType());

    BBSHSVC.update(bbshId, bbsh);

    redirectAttributes.addAttribute("bbshId", bbshId);

    return "redirect:/BBSH/{bbshId}/detail";
  }

  // 삭제
  @GetMapping("/{bbshId}/del")
  public String deleteById(@PathVariable("bbshId") Long bbshId) {
    BBSHSVC.delete(bbshId, AttachFileType.F010202);
    return "redirect:/BBSH";
  }

//  //목록
//  @GetMapping
//  public String findAll(Model model){
//    List<BBSH> bbshes = BBSHSVC.findAll();
//
//    List<DetailForm> detailForms = new ArrayList<>();
//    bbshes.stream().forEach(bbsh->{
//      DetailForm detailForm = new DetailForm();
//      detailForm.setBhContent(bbsh.getBhContent());
//      detailForm.setPetType(bbsh.getPetType());
//      detailForm.setBhHit(bbsh.getBhHit());
//      detailForm.setBhCdate(bbsh.getBhCdate());
//      detailForm.setBhUdate(bbsh.getBhUdate());
////      detailForm.setBhTitle(bbsh.getBhHname());
////      detailForm.setUserNick(bbsh.getUserNick());
//    });
//
//    model.addAttribute("bbshes", bbshes);
//    if (bbshes.size() == 0) {
////      throw new BizException("등록된 상품정보가 없습니다");
//    }
//    return "BBSH/all";
//  }
//
//    //쿼리스트링 카테고리 읽기, 없으면 ""반환
//    private String getCategory(Optional<String> category) {
//      String cate = category.isPresent()? category.get():"";
//      log.info("category={}", cate);
//      return cate;
//    }

  //구인글 목록 페이징
  @GetMapping({"", "/{reqPage}", "/{reqPage}//"})
  public String listPaging(
      @PathVariable(required = false) Optional<Integer> reqPage,
      Model model
  ) {

    fc.getRc().setReqPage(reqPage.orElse(1));
    fc.setTotalRec(BBSHSVC.totalCount());
    log.info("BBSHSVC.totalCount()=", BBSHSVC.totalCount());
    List<BBSH> bbshListsPaging = BBSHSVC.findAllPaging(fc.getRc().getStartRec(), fc.getRc().getEndRec());
    log.info("bbshListsPaging={}", bbshListsPaging);

    List<ListForm> partOfList = new ArrayList<>();
    for (BBSH bbsh : bbshListsPaging) {
      ListForm listForm = new ListForm();
      BeanUtils.copyProperties(bbsh, listForm);
      partOfList.add(listForm);
    }
    log.info("partOfList={}", partOfList);
    model.addAttribute("bbshList", partOfList);
    model.addAttribute("fc", fc);

    return "BBSH/all";
  }
}

